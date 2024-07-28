namespace NP_WebApp_115
{
    public static class SD
    {
        public static string APIBaseUrl = "https://localhost:7021/";
        public static string NationalParkAPIPath = APIBaseUrl + "api/nationalpark";
        public static string TrailAPIPath = APIBaseUrl + "api/trail";
        public static string BookingAPIPath = APIBaseUrl + "api/Booking";

        //Booking Status
        public const string BookingStatusPending = "Pending";
        public const string BookingStatusApproved = "Approved";
        public const string BookingStatusCancelled = "Cancelled";
        public const string BookingStatusRefunded = "Refunded";

        //Payment Status
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusRejected = "Rejected";
    }
}
