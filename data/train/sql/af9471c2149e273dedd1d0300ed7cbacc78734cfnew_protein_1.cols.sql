/*L
   Copyright SAIC

   Distributed under the OSI-approved BSD 3-Clause License.
   See http://ncip.github.com/cabio/LICENSE.txt for details.
L*/

create index NEW_PROTIN_1_PROTEIN_ID on NEW_PROTEIN_1(PROTEIN_ID) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_PRIMARY_AC on NEW_PROTEIN_1(PRIMARY_ACCESSION) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_SECONDARY_ on NEW_PROTEIN_1(SECONDARY_ACCESSION) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_UNIPROTCOD on NEW_PROTEIN_1(UNIPROTCODE) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_KEYWORD on NEW_PROTEIN_1(KEYWORD) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_COPYRIGHTS on NEW_PROTEIN_1(COPYRIGHTSTATEMENT) PARALLEL NOLOGGING tablespace CABIO;
create index NEW_PROTIN_1_NAME on NEW_PROTEIN_1(NAME) PARALLEL NOLOGGING tablespace CABIO;

--EXIT;