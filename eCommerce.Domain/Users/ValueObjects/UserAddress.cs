namespace eCommerce.Domain.Users.ValueObjects
{
    public struct UserAddress
    {
        public string Street;
        public string City;
        public string State;
        public string Country;
        public string ZipCode;

#nullable enable
        public UserAddress(string? street, string? city, string? state, string? country, string? zipCode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }
#nullable disable
    }
}
