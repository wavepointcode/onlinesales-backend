﻿// <copyright file="EmailSchedule.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnlineSales.Entities
{
    public class EmailSchedule : BaseEntity
    {
        /// <summary>
        /// Gets or sets the JSON based schedule assigned for the email group. Examples: {"Cron": "0 0 14 ? ? TUE,THU"}, {"Day": "5,14", "Time": "14.00"}, {"Immediately": "true","Delay": "15"}.
        /// </summary>
        [Required]
        public string Schedule { get; set; } = string.Empty;

        [Required]
        public int GroupId { get; set; }

        [JsonIgnore]
        [ForeignKey("EmailGroupId")]
        public virtual EmailGroup? Group { get; set; }
    }
}