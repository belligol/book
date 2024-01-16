using System.Collections.Generic;
using System;
using BookStore.Models.Data;
using BookStore.DL.Repositories.Mongo;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using Moq;
using Amazon.Runtime.Internal.Util;
using Microsoft.Extensions.Logging;

namespace BookStore.test
{
    public class BookTest
    {
        public static List<Author> Authors = new List<Author>()
    {
        new Author()
                {
                    Id = Guid.NewGuid(),
                    Title = "gosho",
                    Bio = "gosho bio"
                },
        new Author()
                {
                    Id = Guid.NewGuid(),
                    Title = "ginka",
                    Bio = "ginka bio"
                }
    };

        public static List<Book> Books = new List<Book>()
           {
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = "book of gosho",
                    Description = "some description",
                    AuthorId = Guid.NewGuid()
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = "book of gosho",
                    Description = "some description",
                    AuthorId = Guid.NewGuid()
                }
                ,
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = "book of gosho",
                    Description = "some description",
                    AuthorId = Guid.NewGuid()
                }
           };

        [Fact]
        public async Task GetAllBooksByAuthorId_Count_Check()
        {
            var expectedCount = 3;
            var authorId = 1;


            var mockedBookRepository = new Mock<IBookRepository>();
            var logger = new Mock<ILogger<BookService>>();

            mockedBookRepository.Setup(x => x.GetAll()).ReturnsAsync(Books);

            var service = new BookService(mockedBookRepository.Object, logger.Object);

            var result = await service.GetAll();

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        public void TestCalculation_Result_Check()
        {
            var expectedResult = 14;
            var testNumber = 10;

            var mockedBookRepository = new Mock<IBookRepository>();
        }
    }
}