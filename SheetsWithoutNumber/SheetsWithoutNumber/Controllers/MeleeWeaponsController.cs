namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.MeleeWeapons;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.MeleeWeapon;

    public class MeleeWeaponsController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IMeleeWeaponService meleeWeapons;
        private readonly IMapper mapper;

        public MeleeWeaponsController(IMeleeWeaponService meleeWeapons, IMapper mapper, ICharacterService characters)
        {
            this.meleeWeapons = meleeWeapons;
            this.mapper = mapper;
            this.characters = characters;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new MeleeWeaponFormModel
            {
                MeleeWeapons = this.meleeWeapons.GetMeleeWeaponListing()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(MeleeWeaponFormModel meleeWeaponModel, int characterId)
        {
            if (!this.meleeWeapons.MeleeWeaponExists(meleeWeaponModel.MeleeWeaponId))
            {
                this.ModelState.AddModelError(nameof(meleeWeaponModel.MeleeWeaponId), "Melee Weapon does not exist.");
            }

            if (!ModelState.IsValid)
            {
                meleeWeaponModel.MeleeWeapons = this.meleeWeapons.GetMeleeWeaponListing();

                return View(meleeWeaponModel);
            }

            this.meleeWeapons.Add(characterId, meleeWeaponModel.MeleeWeaponId, meleeWeaponModel.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Edit(int characterMeleeWeaponId)
        {
            var characterMeleeWeapon = this.meleeWeapons.GetCharacterMeleeWeaponById(characterMeleeWeaponId);

            var currentUserId = this.User.GetId();
            var currentCharacter = this.characters.GetCharacterById(characterMeleeWeapon.CharacterId);

            if (currentCharacter.OwnerId != currentUserId)
            {
                return Unauthorized();
            }

            var meleeWeaponForm = this.mapper.Map<MeleeWeaponFormModel>(characterMeleeWeapon);

            meleeWeaponForm.MeleeWeapons = this.meleeWeapons.GetMeleeWeaponListing();

            return View(meleeWeaponForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(MeleeWeaponFormModel meleeWeaponEdit)
        {
            var characterMeleeWeapon = this.meleeWeapons.GetCharacterMeleeWeaponById(meleeWeaponEdit.CharacterMeleeWeaponId);

            if (!this.meleeWeapons.MeleeWeaponExists(meleeWeaponEdit.MeleeWeaponId))
            {
                this.ModelState.AddModelError(nameof(meleeWeaponEdit.MeleeWeaponId), "Melee Weapon does not exist.");
            }

            if (!ModelState.IsValid)
            {
                meleeWeaponEdit.MeleeWeapons = this.meleeWeapons.GetMeleeWeaponListing();

                return View(meleeWeaponEdit);
            }

            this.meleeWeapons.Edit( meleeWeaponEdit.MeleeWeaponId, meleeWeaponEdit.CharacterMeleeWeaponId, meleeWeaponEdit.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterMeleeWeapon.CharacterId });
        }

        [Authorize]
        public IActionResult Delete(int characterMeleeWeaponId)
        {
            var characterMeleeWeapon = this.meleeWeapons.GetCharacterMeleeWeaponById(characterMeleeWeaponId);

            meleeWeapons.Delete(characterMeleeWeaponId);

            return RedirectToAction("Details", "Characters", new { characterId = characterMeleeWeapon.CharacterId });
        }
    }
}
