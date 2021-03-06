﻿extern alias ExcelAdomdClientReference;
using System.Collections.Generic;

namespace ADOTabular.AdomdClientWrappers
{
    public class Axis
    {
        private Microsoft.AnalysisServices.AdomdClient.Axis _obj;
        private ExcelAdomdClientReference::Microsoft.AnalysisServices.AdomdClient.Axis _objExcel;

        public Axis(Microsoft.AnalysisServices.AdomdClient.Axis obj)
        {
            _obj = obj;
        }
        public Axis(ExcelAdomdClientReference::Microsoft.AnalysisServices.AdomdClient.Axis obj)
        {
            _objExcel = obj;
        }

        public List<Position> Positions
        {
            get
            {
                if (_obj != null)
                {
                    List<Position> list = new List<Position>();
                    foreach (Microsoft.AnalysisServices.AdomdClient.Position level in _obj.Positions)
                    {
                        list.Add(new Position(level));
                    }
                    return list;
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<List<Position>> f = delegate
                    {
                        List<Position> list = new List<Position>();
                        foreach (ExcelAdomdClientReference::Microsoft.AnalysisServices.AdomdClient.Position level in _objExcel.Positions)
                        {
                            list.Add(new Position(level));
                        }
                        return list;
                    };
                    return f();
                }
            }
        }

    }
}
