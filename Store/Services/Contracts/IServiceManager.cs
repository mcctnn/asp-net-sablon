namespace Services.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IProductService ProductService { get; }
        IOrderService OrderService {get;}
        IAuthService AuthService{get;}
    }
}