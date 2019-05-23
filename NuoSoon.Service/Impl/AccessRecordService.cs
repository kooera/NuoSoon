/**
*
* 功 能： N/A
* 类 名： AccessRecordService
* 作 者： weili
* 时 间： 2019/5/19 22:58:25
* 版 本： 1.0.0.0
* 版 权： Copyright (c) 2019 Mainki. All rights reserved.
*
*/

using System;
using System.Collections.Generic;
using System.Text;
using Vli.Entity.PO;
using Vli.Repository;


namespace NuoSoon.Service.Impl
{
    public class AccessRecordService : BaseService<AccessRecord>, IAccessRecordService<AccessRecord>
    {
        private readonly IAccessRecordRepository recordRepository;

        public AccessRecordService(IBaseRepository<AccessRecord> baseRepository, IAccessRecordRepository recordRepository) : base(baseRepository)
        {
            this.recordRepository = recordRepository;
        }
    }
}
