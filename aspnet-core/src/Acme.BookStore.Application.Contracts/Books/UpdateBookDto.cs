﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Books
{
    public class UpdateBookDto
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
