from django.conf.urls.defaults import *
urlpatterns = patterns('clwmail.admin.views',
    (r'user/manage/page/(?P<page_num>\d{1,})/$'            ,'usermanage'),
    (r'user/manage/page/$'                                 ,'usermanage'),
    (r'user/add/$'                                         ,'useradd'),
    (r'user/(?P<userid>.*)/domain/(?P<domain>.*)/edit/$'   ,'useredit'),
    (r'user/(?P<userid>.*)/domain/(?P<domain>.*)/hide/$'   ,'userhide'),
    (r'user/(?P<userid>.*)/domain/(?P<domain>.*)/unhide/$' ,'userunhide'),
    (r'group/manage/$'                                     ,'groupmanage'),
    (r'group/manage/page/(?P<page_num>\d{1,})/$'           ,'groupmanage'),
    (r'group/(?P<alias>.*)/domain/(?P<domain>.*)/edit/$'   ,'groupedit'),
    (r'group/(?P<alias>.*)/domain/(?P<domain>.*)/delete/$' ,'groupdelete'),
    (r'group/add/$'                                        ,'groupadd'),
    (r'domain/(?P<domain_name>.*)/userget/$'               ,'getaliasusers'),
    (r'domain/manage/$'                                    ,'domainmanage'),
    (r'domain/manage/page/(?P<page_num>\d{1,})/$'          ,'domainmanage'),
    (r'domain/(?P<domain_name>.*)/edit/$'                  ,'domainedit'),
    (r'domain/(?P<domain_name>.*)/delete/$'                ,'domaindelete'),
    (r'domain/add/$'                                       ,'domainadd'),
    (r'genpass/$'                                          ,'genpass'),
    (r''                                                   ,'usermanage'),
)