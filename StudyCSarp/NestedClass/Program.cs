﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach (var iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "";
        }

        private class ItemValue
        {
            private string item;
            private string value;


            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }

            public void SetValue(Configuration config, string item, string value)   //item value를 가지고있는 상위 클래스(configration)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if(config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }
                if (found == false)
                    config.listConfig.Add(this);    //list 추가되는 것
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}
