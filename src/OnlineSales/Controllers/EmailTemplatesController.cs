﻿// <copyright file="EmailTemplatesController.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineSales.Data;
using OnlineSales.DTOs;
using OnlineSales.Entities;

namespace OnlineSales.Controllers;

[Route("api/[controller]")]
public class EmailTemplatesController : BaseController<EmailTemplate, EmailTemplateCreateDto, EmailTemplateUpdateDto>
{
    public EmailTemplatesController(ApiDbContext dbContext, IMapper mapper)
    : base(dbContext, mapper)
    {
    }
}