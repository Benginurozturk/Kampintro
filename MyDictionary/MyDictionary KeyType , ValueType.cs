using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary_KeyType___ValueType
    {
        MyDictionary_KeyType___ValueType[] keyTypes;
        ValueType[] valueTypes;
        MyDictionary_KeyType___ValueType[] tempKeyTypes;
        ValueType[] tempValueTypes;


        public MyDictionary_KeyType___ValueType()
        {
            keyTypes = new MyDictionary_KeyType___ValueType[0];
            valueTypes = new ValueType[0];

        }

        public void Add(MyDictionary_KeyType___ValueType keyType, ValueType valueType)
        {
            tempKeyTypes = keyTypes;
            tempValueTypes = valueTypes;

            keyTypes = new MyDictionary_KeyType___ValueType[keyTypes.Length + 1];
            valueTypes = new ValueType[valueTypes.Length + 1];

            for (int i = 0; i < tempKeyTypes.Length; i++)
            {
                keyTypes[i] = tempKeyTypes[i];
                valueTypes[i] = tempValueTypes[i];
            }
            keyTypes[keyTypes.Length - 1] = keyType;
            valueTypes[valueTypes.Length - 1] = valueType;

        }

        public int Count
        {
            get { return keyTypes.Length; }
        }

        public ValueType[] Value
        {
            get { return valueTypes; }
        }
    }
}
