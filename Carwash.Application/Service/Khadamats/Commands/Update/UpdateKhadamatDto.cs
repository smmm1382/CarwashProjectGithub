﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.Update;

public class UpdateKhadamatDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
