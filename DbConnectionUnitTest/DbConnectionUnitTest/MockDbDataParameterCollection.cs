﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DbConnectionUnitTest
{
    class MockDbDataParameterCollection : List<IDbDataParameter>, IDataParameterCollection
    {
        private List<IDbDataParameter> list;
        public MockDbDataParameterCollection()
        {
            list = new List<IDbDataParameter>();
        }

        public object this[string parameterName]
        {
            get { return list.FirstOrDefault(x => x.ParameterName == parameterName); }
            set { }
        }

        public bool Contains(string parameterName)
        {
            return list.Any(x => x.ParameterName == parameterName);
        }

        public int IndexOf(string parameterName)
        {
            return 1;
        }

        public void RemoveAt(string parameterName)
        {

        }
    }
}
