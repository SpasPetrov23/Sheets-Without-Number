namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Foci;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Focus;
    using System.Linq;

    public class FociController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IFocusService foci;
        private readonly IMapper mapper;

        public FociController(IFocusService foci, IMapper mapper, ICharacterService characters)
        {
            this.foci = foci;
            this.mapper = mapper;
            this.characters = characters;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new FocusFormModel
            {
                PreviousFocusId = null,
                Foci = this.foci.GetFociListing(),
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(FocusFormModel formModel, int characterId)
        {
            if (!this.foci.FocusExists(formModel.FocusId))
            {
                this.ModelState.AddModelError(nameof(formModel.FocusId), "Focus does not exist.");
            }

            if (this.foci.FocusIsLearned(formModel.FocusId, characterId))
            {
                this.ModelState.AddModelError(nameof(formModel.FocusId), "Focus is already learned.");
            }

            if (!this.foci.AllowFocus(formModel.FocusId, characterId))
            {
                this.ModelState.AddModelError(nameof(formModel.FocusId), "This Focus is not available to your class.");
            }

            if (!ModelState.IsValid)
            {
                formModel.Foci = this.foci.GetFociListing();

                return View(formModel);
            }

            this.foci.Add(characterId, formModel.FocusId, formModel.Level);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }


        [Authorize]
        public IActionResult Edit(int characterFocusId)
        {
            var characterFocus = this.foci.GetCharacterFocusById(characterFocusId);

            var currentUserId = this.User.GetId();
            var currentCharacter = this.characters.GetCharacterById(characterFocus.CharacterId);

            if (currentCharacter.OwnerId != currentUserId)
            {
                return Unauthorized();
            }

            var focusForm = this.mapper.Map<FocusFormModel>(characterFocus);

            focusForm.Foci = this.foci.GetFociListing();

            return View(focusForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(FocusFormModel focusEdit)
        {
            var chracterFocus = this.foci.GetCharacterFocusById(focusEdit.CharacterFocusId);

            if (!this.foci.FocusExists(focusEdit.FocusId))
            {
                this.ModelState.AddModelError(nameof(focusEdit.FocusId), "Focus does not exist.");
            }

            if (this.foci.FocusIsLearned(focusEdit.FocusId, chracterFocus.CharacterId) && focusEdit.PreviousFocusId != focusEdit.FocusId)
            {
                this.ModelState.AddModelError(nameof(focusEdit.FocusId), "Focus is already learned.");
            }

            if (!this.foci.AllowFocus(focusEdit.FocusId, chracterFocus.CharacterId))
            {
                this.ModelState.AddModelError(nameof(focusEdit.FocusId), "This Focus is not available to your class.");
            }

            if (!ModelState.IsValid)
            {
                focusEdit.Foci = this.foci.GetFociListing();

                return View(focusEdit);
            }

            this.foci.Edit(focusEdit.Level, focusEdit.FocusId, focusEdit.CharacterFocusId);

            return RedirectToAction("Details", "Characters", new { characterId = chracterFocus.CharacterId });
        }

        [Authorize]
        public IActionResult Delete(int characterFocusId)
        {
            var characterFocus = this.foci.GetCharacterFocusById(characterFocusId);

            foci.Delete(characterFocusId);

            return RedirectToAction("Details", "Characters", new { characterId = characterFocus.CharacterId });
        }
    }
}
