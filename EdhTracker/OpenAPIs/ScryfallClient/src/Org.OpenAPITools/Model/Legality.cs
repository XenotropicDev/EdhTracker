/*
 * Scryfall API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Legality
    /// </summary>
    [DataContract(Name = "legality")]
    public partial class Legality : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Standard
        /// </summary>
        [DataMember(Name = "standard", EmitDefaultValue = false)]
        public LegalStatus? Standard { get; set; }

        /// <summary>
        /// Gets or Sets Future
        /// </summary>
        [DataMember(Name = "future", EmitDefaultValue = false)]
        public LegalStatus? Future { get; set; }

        /// <summary>
        /// Gets or Sets Frontier
        /// </summary>
        [DataMember(Name = "frontier", EmitDefaultValue = false)]
        public LegalStatus? Frontier { get; set; }

        /// <summary>
        /// Gets or Sets Modern
        /// </summary>
        [DataMember(Name = "modern", EmitDefaultValue = false)]
        public LegalStatus? Modern { get; set; }

        /// <summary>
        /// Gets or Sets Legacy
        /// </summary>
        [DataMember(Name = "legacy", EmitDefaultValue = false)]
        public LegalStatus? Legacy { get; set; }

        /// <summary>
        /// Gets or Sets Pauper
        /// </summary>
        [DataMember(Name = "pauper", EmitDefaultValue = false)]
        public LegalStatus? Pauper { get; set; }

        /// <summary>
        /// Gets or Sets Vintage
        /// </summary>
        [DataMember(Name = "vintage", EmitDefaultValue = false)]
        public LegalStatus? Vintage { get; set; }

        /// <summary>
        /// Gets or Sets Penny
        /// </summary>
        [DataMember(Name = "penny", EmitDefaultValue = false)]
        public LegalStatus? Penny { get; set; }

        /// <summary>
        /// Gets or Sets Commander
        /// </summary>
        [DataMember(Name = "commander", EmitDefaultValue = false)]
        public LegalStatus? Commander { get; set; }

        /// <summary>
        /// Gets or Sets Var1v1
        /// </summary>
        [DataMember(Name = "1v1", EmitDefaultValue = false)]
        public LegalStatus? Var1v1 { get; set; }

        /// <summary>
        /// Gets or Sets Duel
        /// </summary>
        [DataMember(Name = "duel", EmitDefaultValue = false)]
        public LegalStatus? Duel { get; set; }

        /// <summary>
        /// Gets or Sets Brawl
        /// </summary>
        [DataMember(Name = "brawl", EmitDefaultValue = false)]
        public LegalStatus? Brawl { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Legality" /> class.
        /// </summary>
        /// <param name="standard">standard.</param>
        /// <param name="future">future.</param>
        /// <param name="frontier">frontier.</param>
        /// <param name="modern">modern.</param>
        /// <param name="legacy">legacy.</param>
        /// <param name="pauper">pauper.</param>
        /// <param name="vintage">vintage.</param>
        /// <param name="penny">penny.</param>
        /// <param name="commander">commander.</param>
        /// <param name="var1v1">var1v1.</param>
        /// <param name="duel">duel.</param>
        /// <param name="brawl">brawl.</param>
        public Legality(LegalStatus? standard = default(LegalStatus?), LegalStatus? future = default(LegalStatus?), LegalStatus? frontier = default(LegalStatus?), LegalStatus? modern = default(LegalStatus?), LegalStatus? legacy = default(LegalStatus?), LegalStatus? pauper = default(LegalStatus?), LegalStatus? vintage = default(LegalStatus?), LegalStatus? penny = default(LegalStatus?), LegalStatus? commander = default(LegalStatus?), LegalStatus? var1v1 = default(LegalStatus?), LegalStatus? duel = default(LegalStatus?), LegalStatus? brawl = default(LegalStatus?))
        {
            this.Standard = standard;
            this.Future = future;
            this.Frontier = frontier;
            this.Modern = modern;
            this.Legacy = legacy;
            this.Pauper = pauper;
            this.Vintage = vintage;
            this.Penny = penny;
            this.Commander = commander;
            this.Var1v1 = var1v1;
            this.Duel = duel;
            this.Brawl = brawl;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Legality {\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Future: ").Append(Future).Append("\n");
            sb.Append("  Frontier: ").Append(Frontier).Append("\n");
            sb.Append("  Modern: ").Append(Modern).Append("\n");
            sb.Append("  Legacy: ").Append(Legacy).Append("\n");
            sb.Append("  Pauper: ").Append(Pauper).Append("\n");
            sb.Append("  Vintage: ").Append(Vintage).Append("\n");
            sb.Append("  Penny: ").Append(Penny).Append("\n");
            sb.Append("  Commander: ").Append(Commander).Append("\n");
            sb.Append("  Var1v1: ").Append(Var1v1).Append("\n");
            sb.Append("  Duel: ").Append(Duel).Append("\n");
            sb.Append("  Brawl: ").Append(Brawl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
