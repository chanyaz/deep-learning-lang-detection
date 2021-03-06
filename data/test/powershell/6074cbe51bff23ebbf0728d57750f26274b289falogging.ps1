
# http://tasteofpowershell.blogspot.com/2011/03/one-approach-to-logging-in-powershell.html

# Add email messages
# http://gallery.technet.microsoft.com/scriptcenter/Write-timestamped-output-4ff1565f

# Add UDP messages : 
# http://www.leporelo.eu/blog.aspx?id=reading-powershell-logs-from-logger-module-in-real-time

<#
TODO: Add UDP COOL!  AND FASTER, asynchronous.....  AND an awesome way to listen remotely....
TODO: add email
TODO: log as per the write-subject - debug, output, error, host
TODO: only log write-output when a flag of -log is included
TODO: Flight recorder --> save the last X thousand messages in an array.  If an error occurs, make them available to the app, regardless of the environment or logging level.  Write them to the log if an error is detected.
TODO: Different logs a) generated by pratom code, b) generated by initial caller ( aka the application )
#>


pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\logging.vars.ps1"))
pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\generate_a_new_log_file_name.ps1"))

generate_a_new_log_file_name

pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\format_log_stuff.ps1"))
pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\pratom.LogLine.add-type.ps1"))
pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\pratom.Log.ps1"))
pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\pratom.Log.Start.ps1"))
pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\pratom.Log.setup.ps1"))

pr_include (code_to_load_a_file ("$(RAILS_PATH_LOGGING)\over_sniffed\over_sniffed.ps1"))