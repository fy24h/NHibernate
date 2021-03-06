﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditTriggerExample.Audit
{

  public interface IExtendedDialect
  {

    string GetCreateTriggerHeaderString(string triggerName,
      string dataTableName, TriggerActions action);

    string GetCreateTriggerFooterString(string triggerName,
      string dataTableName, TriggerActions action);

    string GetDropTriggerString(string triggerName,
      string dataTableName, TriggerActions action);

    string GetInsertIntoString(string destTable, 
      IEnumerable<string> columnNames, string sourceTable, 
      IEnumerable<string> values);

    string QualifyColumn(string tableName, string columnName);

    string GetTriggerNewDataAlias();
    string GetTriggerOldDataAlias();

    string QuoteForTriggerName(string triggerName);

  }

}
