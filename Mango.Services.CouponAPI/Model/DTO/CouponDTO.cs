namespace Mango.Services.CouponAPI.Model.DTO
{
    public class CouponDTO
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
        
    }
}
