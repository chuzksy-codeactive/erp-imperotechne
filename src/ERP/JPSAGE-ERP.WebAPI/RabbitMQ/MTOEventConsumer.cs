using AutoMapper;
using ERP.EventBus;
using ERP.EventBus.Common;
using ERP.EventBus.Events;
using JPSAGE_ERP.Application.Enums;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace JPSAGE_ERP.WebAPI.RabbitMQ
{
    public class MTOEventConsumer
    {
        private readonly IRabbitMQConnection _connection;
        private readonly IMapper _mapper;
        private readonly IMtoRepository _repository;

        public MTOEventConsumer(IMtoRepository repository, IMapper mapper, IRabbitMQConnection connection)
        {
            _repository = repository;
            _mapper = mapper;
            _connection = connection;
        }

        public void Consume()
        {
            var channel = _connection.CreateModel();
            channel.QueueDeclare(queue: EventBusConstants.MtoQueue, durable: false, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);

            //Create event when something is received
            consumer.Received += ReceivedEvent;

            channel.BasicConsume(queue: EventBusConstants.MtoQueue, autoAck: true, consumer: consumer);
        }

        private void ReceivedEvent(object sender, BasicDeliverEventArgs e)
        {
            if (e.RoutingKey == EventBusConstants.MtoQueue)
            {
                var message = Encoding.UTF8.GetString(e.Body.Span);
                var mtoEvent = JsonConvert.DeserializeObject<MaterialTakeOffEvent>(message);

                var mto = _mapper.Map<MtoDto>(mtoEvent);

                if (mtoEvent.DisciplineId == (int)EMtoDiscipline.Civil)
                {
                    var civil = _mapper.Map<ICollection<MtoCivilDetailsDto>>(mtoEvent.MtoCivilDetailsEvents);
                    mto.MtoCivilDetails = civil;
                }

                if (mtoEvent.DisciplineId == (int)EMtoDiscipline.Electrical)
                {
                    var elect = _mapper.Map<ICollection<MtoElectricalDetailsDto>>(mtoEvent.MtoElectricalDetailsEvents);
                    mto.MtoElectricalDetails = elect;
                }

                if (mtoEvent.DisciplineId == (int)EMtoDiscipline.Piping)
                {
                    var piping = _mapper.Map<ICollection<MtoPipingDetailsDto>>(mtoEvent.MtoPipingDetailsEvents);
                    mto.MtoPipingDetails = piping;
                }

                if (mtoEvent.DisciplineId == (int)EMtoDiscipline.Instrument)
                {
                    var instruments = _mapper.Map<ICollection<MtoInstrumentDetailsDto>>(mtoEvent.MtoInstrumentDetailsEvents);
                    mto.MtoInstrumentDetails = instruments;
                }

                var result = _repository.CreateMaterialTakeOff(mto);
            }
        }

        public void Disconnect()
        {
            _connection.Dispose();
        }
    }
}
