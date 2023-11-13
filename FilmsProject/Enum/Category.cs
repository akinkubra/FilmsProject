using System.ComponentModel;

namespace FilmsProject.Enum
{
    public enum Category
    {
        /// <summary>
        /// The Action
        /// </summary>
        [Description("Action")]
        Action = 1,

        /// <summary>
        /// The Comedy
        /// </summary>
        [Description("Comedy")]
        Comedy = 2,

        /// <summary>
        /// The Horror
        /// </summary>
        [Description("Horror")]
        Horror = 3,

        /// <summary>
        /// The Science Fiction
        /// </summary>
        [Description("Science Fiction")]
        ScienceFiction = 4,

        /// <summary>
        /// The Western
        /// </summary>
        [Description("Western")]
        Western = 5,

        /// <summary>
        /// The Love
        /// </summary>
        [Description("Love")]
        Love = 6
    }
}
