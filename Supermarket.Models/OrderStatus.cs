namespace Supermarket.Models
{
   public  enum OrderStatus : byte
    {
        New,
        CheckedOut =11,
        Canceled
    }
}