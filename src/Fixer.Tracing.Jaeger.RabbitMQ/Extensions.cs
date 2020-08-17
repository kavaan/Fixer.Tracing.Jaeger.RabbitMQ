using System;
using Fixer.MessageBrokers.RabbitMQ;
using Fixer.Tracing.Jaeger.RabbitMQ.Middlewares;
using Microsoft.Extensions.DependencyInjection;

namespace Fixer.Tracing.Jaeger.RabbitMQ
{
    public static class Extensions
    {

        public static IFixerBuilder AddJaegerRabbitMqMiddleware(this IFixerBuilder builder)
        {
            builder.Services.AddTransient<IRabbitMqMiddleware, JaegerMiddleware>();

            return builder;
        }
    }
}
