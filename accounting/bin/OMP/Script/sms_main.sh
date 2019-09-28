#!/bin/bash

################################################################
##
##   MySQL Database Backup Script 
##   Written By: Rahul Kumar
##   URL: https://tecadmin.net/bash-script-mysql-database-backup/
##   Last Update: Jan 05, 2019
##
################################################################

export PATH=/bin:/usr/bin:/usr/local/bin
TODAY=`date +"%d%b%Y"`

################################################################
################## Update below values  ########################

DB_BACKUP_PATH='/backup/dbbackup'
MYSQL_HOST='localhost'
MYSQL_PORT='3858'
MYSQL_USER='dbadmin'
MYSQL_PASSWORD='P@$$w0rd'
DATABASE_NAME='sms_main'
BACKUP_RETAIN_DAYS=30

## Number of days to keep local backup copy
#################################################################

mkdir -p ${DB_BACKUP_PATH}/${TODAY}
echo "Backup started for database - ${DATABASE_NAME}"


mysqldump -h ${MYSQL_HOST} \
		  -P ${MYSQL_PORT} \
		  -u ${MYSQL_USER} \
		  -p${MYSQL_PASSWORD} \
		  ${DATABASE_NAME} | gzip > ${DB_BACKUP_PATH}/${TODAY}/${DATABASE_NAME}-${TODAY}.sql.gz

if [ $? -eq 0 ]; then
  echo "Database backup successfully completed"
else
  echo "Error found during backup"
fi


##### Remove backups older than {BACKUP_RETAIN_DAYS} days  #####

DBDELDATE=`date +"%d%b%Y" --date="${BACKUP_RETAIN_DAYS} days ago"`

if [ ! -z ${DB_BACKUP_PATH} ]; then
      cd ${DB_BACKUP_PATH}
      if [ ! -z ${DBDELDATE} ] && [ -d ${DBDELDATE} ]; then
            rm -rf ${DBDELDATE}
      fi
fi

### End of script ####

[18:52:16] - Main Connection String = Server=192.168.10.200;User Id=root;Password=P@$$w0rd;Database=erp_accounting_nhi;Port=3858;allowzerodatetime=True;convertzerodatetime=True;Connect Timeout=6000000
[18:52:16] - FS Connection String = Server=192.168.10.200;User Id=root;Password=P@$$w0rd;Database=erp_fs_alhi;Port=3858;allowzerodatetime=True;convertzerodatetime=True;Connect Timeout=6000000
[18:54:12] - Login Button Click
[18:54:12] - SELECT user_id FROM erp_fs_alhi.sys_erp_user WHERE username = 'alas' AND password = 'a8013ff5b4ddb52f129615ca3b0a9420bdd5ff8bd6e584a4996ffcc454efc580' 
[18:54:12] - INSERT INTO sys_log(log_date,user_id,log_code_3,machine_name,machine_user) VALUES('2019-01-31 18:54:12',1,'a8013ff5b4ddb52f129615ca3b0a9420bdd5ff8bd6e584a4996ffcc454efc580','RAYMONDVILLEGAS','Emon');
[18:54:12] - SELECT log_id AS id FROM sys_log WHERE log_date = '2019-01-31 18:54:12' AND user_id = 1 AND log_code_3 = 'a8013ff5b4ddb52f129615ca3b0a9420bdd5ff8bd6e584a4996ffcc454efc580' AND machine_name = 'RAYMONDVILLEGAS' AND machine_user = 'Emon';
[18:54:12] - SELECT a.stage_id,c.module_code,b.user_id FROM sys_erp_approval a LEFT JOIN sys_erp_approval_user b on b.approval_id = a.approval_id LEFT JOIN sys_erp_modules c ON c.module_id = a.module_id 
[18:54:12] - SELECT a.module_code,b.m_view,b.m_add,b.m_edit,b.m_delete,b.m_cancel,b.m_verify,b.m_approve,b.m_print FROM erp_fs_alhi.sys_erp_modules a LEFT JOIN erp_fs_alhi.sys_erp_profile_det b ON b.module_id = a.module_id LEFT JOIN erp_fs_alhi.sys_erp_user c ON c.profile_id = b.profile_id WHERE a.system_id = 2 AND c.username = 'alas' 
[18:54:13] - SELECT module_code FROM erp_fs_alhi.sys_erp_modules WHERE system_id = 2 
[18:54:13] - select * from lib_erp_journal
[18:54:13] - SELECT a.*,b.company_code,b.company_name,b.address1,b.address2,b.tin,b.rdo_code ,a.currency_id,c.currency_code,c.currency_name,c.symbol  FROM sys_default a  LEFT JOIN erp_fs_alhi.lib_erp_company b ON b.company_id = a.company_id LEFT JOIN erp_fs_alhi.lib_erp_currency c ON c.currency_id = a.currency_id 
[18:54:13] - select a.*,b.module_code from sys_default_det a inner join erp_fs_alhi.sys_erp_modules b on a.module_id = b.module_id
[18:54:14] - SELECT a.book_id,a.book_code,a.book_name FROM lib_erp_book a WHERE a.company_id = '6'
[18:54:14] - SELECT 1 AS id,'January' AS name UNION SELECT 2,'February' UNION SELECT 3,'March' UNION SELECT 4,'April' UNION SELECT 5,'May' UNION SELECT 6,'June' UNION SELECT 7,'July' UNION SELECT 8,'August' UNION SELECT 9,'September' UNION SELECT 10,'October' UNION SELECT 11,'November' UNION SELECT 12,'December' 
[18:54:14] - End of Initialization
[18:55:16] - ----- Accounting Close -----