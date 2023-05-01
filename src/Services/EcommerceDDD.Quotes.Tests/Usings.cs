global using Moq;
global using Xunit;
global using FluentAssertions;
global using EcommerceDDD.Core.Testing;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Quotes.Domain;
global using EcommerceDDD.Quotes.Domain.Events;
global using EcommerceDDD.Quotes.Domain.Commands;
global using EcommerceDDD.Quotes.Application.Products;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Quotes.Application.Quotes.AddingQuoteItem;
global using EcommerceDDD.Quotes.Application.Quotes.CancelingQuote;
global using EcommerceDDD.Quotes.Application.Quotes.OpeningQuote;
global using EcommerceDDD.Quotes.Application.Quotes.ConfirmingQuote;
global using EcommerceDDD.Quotes.Application.Quotes.RemovingQuoteItem;