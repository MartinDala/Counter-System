/*
 * Criado por SharpDevelop.
 * Usuário: Pedro
 * Data: 26/05/2015
 * Hora: 18:59
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace JARVIS
{
	/// <summary>
	/// Description of SystemInfo.
	/// </summary>
	public class SystemInfo
	{
        /// <summary>
        /// Default constructor.
        /// </summary>
		public SystemInfo()
		{
			
		}

        /// <summary>
        /// Returns the time, ready for the speech synthesizer.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            string currentHour = time.ToShortTimeString();
            string[] vet = currentHour.Split(':');
            string result = "São " + vet[0] + " horas e " + vet[1] + " minutos.";
            return result;
        }
        /// <summary>
        /// Returns the date, ready for reading.
        /// </summary>
        /// <returns></returns>
		public string GetCurrentDate()
		{
            string currentDate = DateTime.Today.ToString("dd/mm/yyyy");
			string result = "Hoje é " + currentDate;
			return result;
		}

        /// <summary>
        /// Returns todays date, ready for reading.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentDay()
        {
            string result = DateTime.Today.ToString("dd");
            string res = "hoje é " + result;
            return res;
        }
	}
}
