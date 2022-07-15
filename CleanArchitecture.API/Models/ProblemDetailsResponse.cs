namespace CleanArchitecture.API.Models
{
    public class ProblemDetailsResponse
    {
        /// <summary>
        /// Indicates that the call response is inccorrect.
        /// </summary>
        /// <value>
        /// The code result.
        /// </value>
        /// <example>False</example>
        public bool Success { get; set; }
        /// <summary>
        /// The code result.
        /// </summary>
        /// <value>
        /// The code result.
        /// </value>
        /// <example>400</example>
        public String CodeResult { get; set; }
        /// <summary>
        /// The message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        /// <example>Bad Request, problem with parametes, variables or model.</example>
        public String Message { get; set; }
        /// <summary>
        /// In this case it is always null, because there is no data to display.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public String Data { get; set; }
    }
}
