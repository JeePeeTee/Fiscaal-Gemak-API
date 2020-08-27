/* 
 * Fiscaal Gemak API
 *
 * Fiscaal Gemak API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: jpt@sultancrm.nl
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json.Converters;

namespace FG.Api.Client
{
    /// <summary>
    /// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
    /// </summary>
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}