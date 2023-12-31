global using Xunit;
global using System;
global using System.Linq;
global using NSubstitute;
global using FluentAssertions;
global using System.Threading;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Mvc;
global using EcommerceDDD.Core.Testing;
global using System.Collections.Generic;
global using EcommerceDDD.Orders.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Orders.Domain.Events;
global using EcommerceDDD.Orders.Domain.Commands;
global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Orders.API.Controllers;
global using EcommerceDDD.Core.Infrastructure.SignalR;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Orders.Application.GettingOrderEventHistory;
global using EcommerceDDD.Orders.Application.Orders.GettingOrders;
global using EcommerceDDD.Orders.Application.Orders.CompletingOrder;
global using EcommerceDDD.Orders.Application.Orders.CancelingOrder;
global using EcommerceDDD.Orders.Application.Orders.PlacingOrder;
global using EcommerceDDD.Orders.Application.Orders.RecordingPayment;