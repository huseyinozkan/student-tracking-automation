﻿using MySoft.OgrenciTakip.Bll.Base;
using MySoft.OgrenciTakip.Bll.Functions;
using MySoft.OgrenciTakip.Bll.Interfaces;
using MySoft.OgrenciTakip.Data.Contexts;
using MySoft.OgrenciTakip.Model.Dto;
using MySoft.OgrenciTakip.Model.Entities;
using MySoft.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MySoft.OgrenciTakip.Bll.General
{
    public class EposBilgileriBll : BaseHareketBll<EposBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EposBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EposBilgileri, bool>> filter)
        {
            var entities = List(filter, x => new EposBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BankaId = x.BankaId,
                BankaAdi = x.Banka.BankaAdi,
                KartTuru = x.KartTuru,
                KartNo = x.KartNo,
                SonKullanmaTarihi = x.SonKullanmaTarihi,
                GuvenlikKodu = x.GuvenlikKodu
            }).ToList();

            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;
                entity.KartNo = entity.KartNo.Decrypt(anahtar);
                entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Decrypt(anahtar);
                entity.GuvenlikKodu = entity.GuvenlikKodu.Decrypt(anahtar);
            }

            return entities;
        }

        public override bool Insert(IList<BaseHareketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;
                entity.KartNo = entity.KartNo.Encrypt(anahtar);
                entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Encrypt(anahtar);
                entity.GuvenlikKodu = entity.GuvenlikKodu.Encrypt(anahtar);
            }

            return base.Insert(entities);
        }

        public override bool Update(IList<BaseHareketEntity> entities)
        {
            foreach (EposBilgileriL entity in entities)
            {
                var anahtar = entity.TahakkukId + "" + entity.BankaId;
                entity.KartNo = entity.KartNo.Encrypt(anahtar);
                entity.SonKullanmaTarihi = entity.SonKullanmaTarihi.Encrypt(anahtar);
                entity.GuvenlikKodu = entity.GuvenlikKodu.Encrypt(anahtar);
            }

            return base.Update(entities);
        }
    }
}
