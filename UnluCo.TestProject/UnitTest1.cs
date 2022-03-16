using AutoMapper;
using Moq;
using ProductUnluCo.Application.Mappings;
using ProductUnluCo.Domain.Interface;
using ProductUnluCo.Infrastructure.Context;
using ProductUnluCo.Infrastructure.Repositories;
using ProductUnluCo.Infrastructure.UnitOfWorks;
using System;
using Xunit;
using static UnluCo.TestProject.TextFix;

namespace UnluCo.TestProject
{
    public class ProductRepositoryTests : IClassFixture<TextFix>
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly IMapper _mapper;
        private readonly ProductDbContext _context;
            public ProductRepositoryTests(TextFixture textFixture)
            {
                _context = textFixture.Context;
              
                 _unitOfWorkMock = new Mock<IUnitOfWork>();
                _productRepositoryMock = new Mock<IProductRepository>();
              _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new ProductProfile())));
            }




        [Fact]
        public void GetAll_ProductList()
        {
            var repository = new ProductRepository(_context);
            var products = repository.GetAll();

            Assert.NotEmpty(products);
            Assert.Equal(4, products.Count());
        }



        [Fact]
        public void Get_return()
        {
            var repository = new ProductRepository(_context);
            var products = repository.Get(x => x.ProductName == "Ayakkabý");
            Assert.NotEmpty(products);
        }
    }
}
