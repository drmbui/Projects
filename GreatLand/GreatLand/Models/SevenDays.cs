using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace GreatLand.Models
{
    public class SevenDays
    {
        public string Value { get; set; }
        public int Key { get; set; }


        public SevenDays(string value,
                        int key)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
