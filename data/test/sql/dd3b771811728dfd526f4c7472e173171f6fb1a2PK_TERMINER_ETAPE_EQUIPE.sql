--------------------------------------------------------
--  DDL for Index PK_TERMINER_ETAPE_EQUIPE
--------------------------------------------------------

  CREATE UNIQUE INDEX "G11_FLIGHT"."PK_TERMINER_ETAPE_EQUIPE" ON "G11_FLIGHT"."TERMINER_ETAPE_EQUIPE" ("TOUR_ANNEE", "EQUIPE_NUM", "ETAPE_NUM") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "BD50_DATA" ;