global using Marten;
global using System.Net;
global using Newtonsoft.Json;
global using Marten.Events.Projections;
global using Marten.Events.Aggregation;
global using EcommerceDDD.Core.Domain;
global using Microsoft.AspNetCore.Mvc;
global using EcommerceDDD.Core.EventBus;
global using EcommerceDDD.Payments.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.Payments.Domain.Events;
global using EcommerceDDD.Core.Infrastructure;
global using Microsoft.AspNetCore.Authorization;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using System.ComponentModel.DataAnnotations;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.Infrastructure.Kafka;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Payments.API.Controllers.Requests;
global using EcommerceDDD.Core.Infrastructure.Outbox.Services;
global using EcommerceDDD.Payments.Domain.Commands;
global using EcommerceDDD.Core.Infrastructure.Outbox;
global using EcommerceDDD.Payments.Infrastructure.Projections;
global using EcommerceDDD.Payments.Application.ProcessingPayment;
global using EcommerceDDD.Payments.Application.RequestingPayment;