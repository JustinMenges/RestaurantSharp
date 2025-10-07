using Moq;
using RestaurantSharp.Application.Common.Interfaces;
using RestaurantSharp.Application.CQRS.MenuItems.Queries.GetAvailable;

namespace RestaurantSharp.UnitTest.CQRS.MenuItems.Queries.GetAvailable;

[TestFixture]
public class GetAvailableMenuItemsHandlerTests
{
    private Mock<IMenuItemRepository> _mockRepo;
    private GetAvailableMenuItemsHandler _handler;

    [SetUp]
    public void Setup()
    {
        _mockRepo = new Mock<IMenuItemRepository>();
        _handler = new GetAvailableMenuItemsHandler(_mockRepo.Object);
    }
}
