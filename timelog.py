import pymssql
conn = pymssql.connect(host='10.57.2.96\SQLEXPRESS', database='HadzapiDtb')
cursor = conn.cursor()
cursor.execute("""
USE HadzapiDtb
SELECT syscolumns.name AS name, systypes.name AS type FROM syscolumns LEFT JOIN systypes ON syscolumns.xtype = systypes.xtype WHERE syscolumns.id = 2142630676
""")
row = cursor.fetchone()
while row:
    print row
    row = cursor.fetchone()

conn.close()
