﻿using EFCustomerLibrary.Enums;

namespace EFCustomerLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string FirstLine { get; set; } = String.Empty;

        public string SecondLine { get; set; } = String.Empty;

        public AddressType Type { get; set; } = AddressType.Billing;

        public string City { get; set; } = String.Empty;

        public string PostalCode { get; set; } = String.Empty;

        public string State { get; set; } = String.Empty;

        public AvailableCountries Country { get; set; } = AvailableCountries.Canada;

        public int CustomerId { get; set; }
    }
}
