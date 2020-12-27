using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCDAMaxEntropy.ML.Objects
{
    public class EmailPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Category;
    }
}
