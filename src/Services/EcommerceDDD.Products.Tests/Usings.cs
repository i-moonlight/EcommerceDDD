global using Xunit;
global using NSubstitute;
global using FluentAssertions;
global using Microsoft.AspNetCore.Mvc;
global using EcommerceDDD.Products.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Products.API.Controllers;
global using EcommerceDDD.Products.API.Controllers.Requests;
global using EcommerceDDD.Products.Application.Products.GettingProducts;
global using EcommerceDDD.Products.Application.Products.CheckingProductStockAvailability;