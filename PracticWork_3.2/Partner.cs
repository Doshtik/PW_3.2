﻿using System;
using System.Collections.Generic;

namespace PracticWork_3._2;

public partial class Partner
{
    public int Id { get; set; }

    public int IdOfPartner { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string FullnameOfDirector { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short Rating { get; set; }

    public virtual ICollection<FromProductsToPartner> FromProductsToPartners { get; set; } = new List<FromProductsToPartner>();

    public virtual TypesOfPartner IdOfPartnerNavigation { get; set; } = null!;
}
