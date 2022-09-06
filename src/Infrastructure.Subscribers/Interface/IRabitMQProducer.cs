using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Subscribers.Interface
{
    public interface IRabitMQProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
