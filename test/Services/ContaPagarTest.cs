using System;
using System.Threading.Tasks;
using Moq;
using test_deliverit.src.Core.Domain.Dtos;
using test_deliverit.src.Core.Domain.Entities;
using test_deliverit.src.Core.Domain.Interfaces.Services;
using Xunit;

namespace test_deliverit.test.Services
{
    public class ContaPagarTest: ContaPagarBaseTest
    {   
        private IContaPagarService _service;
        private Mock<IContaPagarService> _serviceMock;

        [Fact(DisplayName = "Execute Create Test.")]
        public async Task ExecuteCreateTest()
        {
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Post(contaPagarInserirDto)).ReturnsAsync(contaPagarDto);
            _service = _serviceMock.Object;

            var result = await _service.Post(contaPagarInserirDto);
            Assert.NotNull(result);
            Assert.Equal(Id, result.Id);
            Assert.Equal(Nome, result.Nome);
        }

        [Fact(DisplayName = "Execute Update Test.")]
        public async Task ExecuteUpdateTest()
        {
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Put(contaPagarDto)).ReturnsAsync(contaPagarDto);
            _service = _serviceMock.Object;

            var result = await _service.Put(contaPagarDto);
            Assert.NotNull(result);
            Assert.Equal(Id, result.Id);
            Assert.Equal(Nome, result.Nome);
        }

        [Fact(DisplayName = "Execute calculo juros e multa")]
        public async Task ExecuteCalculosTest() {
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Put(contaPagarDto)).ReturnsAsync(contaPagarDto);
            _service = _serviceMock.Object; 

            var result = await _service.Put(contaPagarDto);
            Assert.NotNull(result);
            Assert.Equal(PercentualMulta, result.PercentualMulta);
            Assert.Equal(PercentualJuroDia, result.PercentualJuroDia);
            Assert.Equal(ValorCorrigido, result.ValorCorrigido);
        }

        [Fact(DisplayName = "Execute Delete Test.")]
        public async Task ExecuteDeleteTest()
        {
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Delete(Id))
                        .ReturnsAsync(true);
            _service = _serviceMock.Object;

            var delete = await _service.Delete(Id);
            Assert.True(delete);

            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Delete(It.IsAny<Guid>()))
                        .ReturnsAsync(false);
            _service = _serviceMock.Object;

            delete = await _service.Delete(Guid.NewGuid());
            Assert.False(delete);
        }

        [Fact(DisplayName = "Execute GET Test.")]
        public async Task ExecuteGetTest()
        {
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Get(Id)).ReturnsAsync(contaPagarGetDto);
            _service = _serviceMock.Object;

            var result = await _service.Get(Id);
            Assert.NotNull(result);
            Assert.Equal(Nome, result.Nome);
            
            _serviceMock = new Mock<IContaPagarService>();
            _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((ContaPagarGetDto)null));
            _service = _serviceMock.Object;

            var _record = await _service.Get(Guid.NewGuid());
            Assert.Null(_record);
        }
        
    }
}