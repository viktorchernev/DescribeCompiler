using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Unfold
{
    public partial class DescribeUnfold
    {
        /// <summary>
        /// Get a json string representation of a <see cref="DescribeUnfold"/>. 
        /// Used as means for serialization.
        /// </summary>
        /// <returns>
        /// JSON string, representing the <see cref="DescribeUnfold"/>.
        /// </returns>
        public string ToJson()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }

        /// <summary>
        /// Populate this <see cref="DescribeUnfold"/> object with values from json string.
        /// Used as means for deserialization.
        /// </summary>
        /// <param name="json">The JSON containing the values.</param>
        public void FromJson(string json)
        {
            JsonConvert.PopulateObject(json, this);
        }
    }
}
