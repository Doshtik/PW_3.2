﻿using System;
using System.Collections.Generic;

namespace PracticWork_3._2;

public partial class FromProductsToPartner
{
    public int Id { get; set; }

    public int IdOfPartner { get; set; }

    public int IdOfProduct { get; set; }

    public int Amount { get; set; }

    public DateTime DateOfSelling { get; set; }

    public virtual Partner IdOfPartnerNavigation { get; set; } = null!;

    public virtual Product IdOfProductNavigation { get; set; } = null!;
}