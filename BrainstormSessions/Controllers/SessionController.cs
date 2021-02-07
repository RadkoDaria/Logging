using System.Threading.Tasks;
using BrainstormSessions.Core.Interfaces;
using BrainstormSessions.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BrainstormSessions.Controllers
{
    public class SessionController : Controller
    {
        private readonly IBrainstormSessionRepository _sessionRepository;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));

        public SessionController(IBrainstormSessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public async Task<IActionResult> Index(int? id)
        {
          
            if (!id.HasValue)
            {             
                return RedirectToAction(actionName: nameof(Index),
                    controllerName: "Home");
            }
            var session = await _sessionRepository.GetByIdAsync(id.Value);
            if (session == null)
            {
                return Content("Session not found.");
            }

            var viewModel = new StormSessionViewModel()
            {
                DateCreated = session.DateCreated,
                Name = session.Name,
                Id = session.Id
            };
            _log4net.Debug("Debug message");
            _log4net.Debug("Debug message2");
            return View(viewModel);
        }
    }
}
