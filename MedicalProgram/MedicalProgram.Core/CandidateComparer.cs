using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Entity;

namespace MedicalProgram.Core
{
    public class CandidateComparer : IComparer<Candidate>
    {
        public int Compare(Candidate x, Candidate y)
        {
            if (x.TotalMark == y.TotalMark)
            {
                if (x.BioMark == y.BioMark)
                {
                    if (x.ChemMark == y.ChemMark)
                    {
                        if (x.PhyMark == y.PhyMark)
                        {
                            if (x.EngMark == y.EngMark)
                            {
                                if (x.GkMark == y.GkMark)
                                {
                                    return 0;
                                }
                                else if (x.GkMark > y.GkMark) return 1;
                                else return -1;
                            }
                            else if (x.EngMark > y.EngMark) return 1;
                            else return -1;
                        }
                        else if (x.PhyMark > y.PhyMark) return 1;
                        else return -1;
                    }
                    else if (x.ChemMark > y.ChemMark) return 1;
                    else return -1;
                }
                else if (x.BioMark > y.BioMark) return 1;
                else return -1;
            }
            else if (x.TotalMark > y.TotalMark) return 1;
            else return -1;
        }
    }
    public class PreferenceComparer : IComparer<Candidate>
    {
        public int Compare(Candidate x, Candidate y)
        {
            if (x.TotalMark == y.TotalMark)
            {
                if (x.BioMark == y.BioMark)
                {
                    if (x.ChemMark == y.ChemMark)
                    {
                        if (x.PhyMark == y.PhyMark)
                        {
                            if (x.EngMark == y.EngMark)
                            {
                                if (x.GkMark == y.GkMark)
                                {
                                    return 0;
                                }
                                else if (x.GkMark > y.GkMark) return 1;
                                else return -1;
                            }
                            else if (x.EngMark > y.EngMark) return 1;
                            else return -1;
                        }
                        else if (x.PhyMark > y.PhyMark) return 1;
                        else return -1;
                    }
                    else if (x.ChemMark > y.ChemMark) return 1;
                    else return -1;
                }
                else if (x.BioMark > y.BioMark) return 1;
                else return -1;
            }
            else if (x.TotalMark > y.TotalMark) return 1;
            else return -1;
        }
    }
}
