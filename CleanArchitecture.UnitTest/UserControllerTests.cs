using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class UserControllerTests
    {
        private readonly Mock<IMediator> _mediatorMock;
        private readonly UserController _controller;

        public UserControllerTests()
        {
            _mediatorMock = new Mock<IMediator>();
            _controller = new UserController(_mediatorMock.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsOkObjectResult()
        {
            // Arrange
            var expectedResponse = new List<GetAllUserResponse>(); // Simulación de una respuesta esperada
            _mediatorMock.Setup(x => x.Send(It.IsAny<GetAllUserRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.GetAll(CancellationToken.None);

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
