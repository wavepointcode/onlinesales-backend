﻿// <copyright file="IContactService.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using OnlineSales.Entities;

namespace OnlineSales.Interfaces
{
    public interface IContactService : IEntityService<Contact>
    {
        Task Unsubscribe(string email, string reason, string source, DateTime createdAt, string? ip);

        /// <summary>
        /// Update <see cref="Contact.LastIp"/> and return new <see  langword="IpAddress"/> back.
        /// </summary>
        /// <param name="contact">Entity to update.</param>
        /// <returns>String value of current IP Address or <see langword="null"/>.</returns>
        public string? UpdateContactIp(Contact contact);
    }
}