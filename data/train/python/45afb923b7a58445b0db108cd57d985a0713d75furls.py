from django.conf.urls.defaults import *

urlpatterns = patterns('',
    url(r'^$',
        'django_gitweb.views.repository_list',
        name='gitweb_repository_list'),
    url(r'^(?P<slug>[\w-]+)/$',
        'django_gitweb.views.repository_summary',
        name='gitweb_repository_summary'),
    url(r'^(?P<slug>[\w-]+)/commit/(?P<commit>[\w-]+)/$',
        'django_gitweb.views.repository_commit',
        name='gitweb_repository_commit'),
    url(r'^(?P<slug>[\w-]+)/commit/(?P<commit>[\w-]+)/diff/$',
        'django_gitweb.views.repository_commit', {'template_name': 'gitweb/repository_commit_diff.html'},
        name='gitweb_repository_commit_diff'),
    url(r'^(?P<slug>[\w-]+)/tree/(?P<branch>[\w-]+)/(?P<path>.*)$',
        'django_gitweb.views.repository_tree',
        name='gitweb_repository_tree'),
    url(r'^(?P<slug>[\w-]+)/log/(?P<branch>[\w-]+)/$',
        'django_gitweb.views.repository_log',
        name='gitweb_repository_log'),
    url(r'^(?P<slug>[\w-]+)/log/$',
        'django_gitweb.views.repository_log',
        name='gitweb_repository_log'),
)