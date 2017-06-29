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
    public class Seats
    {
        public string Value { get; set; }
        public string Key { get; set; }


        public Seats(string value,
                        string key)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
