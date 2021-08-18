namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.RangedWeapons;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.RangedWeapon;

    public class RangedWeaponsController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IRangedWeaponService rangedWeapons;
        private readonly IMapper mapper;

        public RangedWeaponsController(IRangedWeaponService rangedWeapons, IMapper mapper, ICharacterService characters)
        {
            this.rangedWeapons = rangedWeapons;
            this.mapper = mapper;
            this.characters = characters;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new RangedWeaponFormModel
            {
                RangedWeapons = this.rangedWeapons.GetRangedWeaponListing()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(RangedWeaponFormModel rangedWeaponModel, int characterId)
        {
            if (!this.rangedWeapons.RangedWeaponExists(rangedWeaponModel.RangedWeaponId))
            {
                this.ModelState.AddModelError(nameof(rangedWeaponModel.RangedWeaponId), "Ranged Weapon does not exist.");
            }

            if (!this.rangedWeapons.IsAmmoValid(rangedWeaponModel.Ammo, rangedWeaponModel.RangedWeaponId))
            {
                this.ModelState.AddModelError(nameof(rangedWeaponModel.Ammo), "Ammo cannot be higher than Magazine.");
            }

            if (!ModelState.IsValid)
            {
                rangedWeaponModel.RangedWeapons = this.rangedWeapons.GetRangedWeaponListing();

                return View(rangedWeaponModel);
            }

            this.rangedWeapons.Add(characterId, rangedWeaponModel.RangedWeaponId, rangedWeaponModel.Ammo, rangedWeaponModel.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Edit(int characterRangedWeaponId)
        {
            var characterRangedWeapon = this.rangedWeapons.GetCharacterRangedWeaponById(characterRangedWeaponId);

            var currentUserId = this.User.GetId();
            var currentCharacter = this.characters.GetCharacterById(characterRangedWeapon.CharacterId);

            if (currentCharacter.OwnerId != currentUserId)
            {
                return Unauthorized();
            }

            var rangedWeaponForm = this.mapper.Map<RangedWeaponFormModel>(characterRangedWeapon);

            rangedWeaponForm.RangedWeapons = this.rangedWeapons.GetRangedWeaponListing();

            return View(rangedWeaponForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(RangedWeaponFormModel rangedWeaponEdit)
        {
            var characterRangedWeapon = this.rangedWeapons.GetCharacterRangedWeaponById(rangedWeaponEdit.CharacterRangedWeaponId);

            if (!this.rangedWeapons.RangedWeaponExists(rangedWeaponEdit.RangedWeaponId))
            {
                this.ModelState.AddModelError(nameof(rangedWeaponEdit.RangedWeaponId), "Ranged Weapon does not exist.");
            }

            if (!this.rangedWeapons.IsAmmoValid(rangedWeaponEdit.Ammo, rangedWeaponEdit.RangedWeaponId))
            {
                this.ModelState.AddModelError(nameof(rangedWeaponEdit.Ammo), "Ammo cannot be higher than Magazine.");
            }

            if (!ModelState.IsValid)
            {
                rangedWeaponEdit.RangedWeapons = this.rangedWeapons.GetRangedWeaponListing();

                return View(rangedWeaponEdit);
            }

            this.rangedWeapons.Edit(rangedWeaponEdit.RangedWeaponId, rangedWeaponEdit.CharacterRangedWeaponId, rangedWeaponEdit.Ammo, rangedWeaponEdit.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterRangedWeapon.CharacterId });
        }

        [Authorize]
        public IActionResult Delete(int characterRangedWeaponId)
        {
            var characterRangedWeapon = this.rangedWeapons.GetCharacterRangedWeaponById(characterRangedWeaponId);

            rangedWeapons.Delete(characterRangedWeaponId);

            return RedirectToAction("Details", "Characters", new { characterId = characterRangedWeapon.CharacterId });
        }
    }
}
