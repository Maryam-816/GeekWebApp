using GeekWebAppProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Infastracture
{
    public static class DbContextExtension
    {
        
        public static IEnumerable<Article> GetArticlesData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.Articles.OrderByDescending(article => article.ImagePath).
                                                    Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new Article
                                                    {
                                                        Id = x.Id,
                                                        Name = x.Name,
                                                        ImagePath = x.ImagePath,
                                                        Text = x.Text
                                                    }).ToList();

        }
       
        public static IEnumerable<Feedback> GetFeedBackData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.Feedbacks.Select(x => new Feedback
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                Text = x.Text, 
                ClientFullName = x.ClientFullName,
                ClientJob = x.ClientJob
            }).ToList();
        }
        
        public static IEnumerable<Footer> GetFooterData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.Footers.Select(x => new Footer
            {
                Id = x.Id,
                Text = x.Text
            }).ToList();
        }
        
        public static IEnumerable<Menu> GetMenuData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.Menus.Select(x => new Menu
                                           {
                                            Id = x.Id,
                                            LogoImagePath = x.LogoImagePath,
                                            Name = x.Name,
                                            Text = x.Text,
                                            NavName = x.NavName
                                           }).ToList();
        }
       
        public static IEnumerable<SkillsModel> GetSkillsModelData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return  _geekDbContext.SkillsModels.Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new SkillsModel
                                                    {
                                                        Id = x.Id,
                                                        Procent = x.Procent,
                                                        Language = x.Language,
                                                        
                                                    }).ToList();

        }
        
        public static IEnumerable<ValuableClients> GetValuableClientsData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.ValuableClients.Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new ValuableClients
                                                    {
                                                        Id = x.Id,
                                                        ImagePath = x.ImagePath

                                                    }).ToList();

        }
        
        public static IEnumerable<WorkModel> GetWorkModelData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.WorkModels.Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new WorkModel
                                                    {
                                                        Id = x.Id,
                                                        ImagePath = x.ImagePath,
                                                        Text = x.Text

                                                    }).ToList();

        }

        public static IEnumerable<ContactInfo> GetContactInfoData(this GeekDbContext _geekDbContext, int page, int _ItemPerPage)
        {
            return _geekDbContext.ContactInfos.Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new ContactInfo
                                                    {
                                                        Id = x.Id,
                                                        Name = x.Name,
                                                        Info = x.Info

                                                    }).ToList();

        }

    }
}