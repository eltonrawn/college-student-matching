using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalProgram.Data;

namespace MedicalProgram.Core
{
    public class LoginCheck
    {
        public bool AdminLoginIdCheck(string LoginId)   {
            return (new LoginDatabase()).AdminLoginIdCheck(LoginId);
        }
        public bool AdminPassCheck(string LoginId, string pass)
        {
            return (new LoginDatabase()).AdminPassCheck(LoginId, pass);
        }
        public bool CanLoginIdCheck(string LoginId)
        {
            return (new LoginDatabase()).CanLoginIdCheck(LoginId);
        }
        public bool CanPassCheck(string LoginId, string pass)
        {
            return (new LoginDatabase()).CanPassCheck(LoginId, pass);
        }
        public int getPrefCnt(int candidateNo) {
            return (new LoginDatabase()).getPrefCnt(candidateNo);
        }
        public int getCollege(int candidateNo)
        {
            return (new LoginDatabase()).getCollege(candidateNo);
        }
        public int getCandidateNo(int loginId)
        {
            return (new LoginDatabase()).getCandidateNo(loginId);
        }

        public void updateClg(int candidateNo, int collegeNo)
        {
            (new LoginDatabase()).updateClg(candidateNo, collegeNo);
        }
    }
}
