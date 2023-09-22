﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class LendingAndReturnsBooksList : List<LendingAndReturnsBooks>
    {
        public LendingAndReturnsBooksList() { }

        public LendingAndReturnsBooksList(IEnumerable<LendingAndReturnsBooks> list) : base(list) { }

        public LendingAndReturnsBooksList(IEnumerable<BaseEntity> list) : base(list.Cast<LendingAndReturnsBooks>().ToList()) { }

    }
}
