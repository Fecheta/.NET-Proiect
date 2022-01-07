﻿using Application.Features.Commands;
using Application.Interfaces;
using Domain.Entities;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Utils;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using PricePrediction;


namespace Tests.Application.Utils
{
    public class PricePredictHandlerTests
    {
        public class UpdateHouseHandlerTests
        {
            private Mock<Program> _repository;
            private PricePredictUtilHandler _handler;
            private PricePredictUtil _command;

            [SetUp]
            public void Init()
            {
                _repository = new Mock<Program>();
                _handler = new PricePredictUtilHandler();
                CreateCommand();
                
            }

            [TearDown]
            public void Clear()
            {
                _repository = null;
                _handler = null;
            }

            [Test]
            public async Task ShouldSendHouse()
            {
                // _repository.Setup(m => m.PricePredict(It.IsAny<PricePredictUtil>()))
                //     .Returns(Task.FromResult(new float()));
                
                var result = await _handler.Handle(_command, new CancellationToken());

                _repository.Verify(m => m.PricePredict(It.IsAny<PricePredictUtil>()), Times.Once);
            }

            private void CreateCommand()
            {
                _command = new PricePredictUtil
                {
                    Zipcode = "sm11hf",
                    Bedrooms = 10,
                    Bathrooms = 2,
                    SquareFeet = 100,
                    YearBuit = 2000,
                    Floors = "10"
                };
            }
        }
    }
}