namespace SheetsWithoutNumber.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Models.Equipments;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Equipments;

    public class EquipmentsController : Controller
    {
        private readonly ICharacterService characters;
        private readonly IEquipmentService equipments;
        private readonly IMapper mapper;

        public EquipmentsController(IEquipmentService equipments, IMapper mapper, ICharacterService characters)
        {
            this.equipments = equipments;
            this.mapper = mapper;
            this.characters = characters;
        }

        [Authorize]
        public IActionResult Add()
        {
            return View(new EquipmentFormModel
            {
                Equipments = this.equipments.GetEquipmentListing()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(EquipmentFormModel equipmentModel, int characterId)
        {
            if (!this.equipments.EquipmentExists(equipmentModel.EquipmentId))
            {
                this.ModelState.AddModelError(nameof(equipmentModel.EquipmentId), "Equipment does not exist.");
            }

            if (!ModelState.IsValid)
            {
                equipmentModel.Equipments = this.equipments.GetEquipmentListing();

                return View(equipmentModel);
            }

            this.equipments.Add(characterId, equipmentModel.EquipmentId, equipmentModel.Count, equipmentModel.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterId });
        }

        [Authorize]
        public IActionResult Edit(int characterEquipmentId)
        {
            var characterEquipment = this.equipments.GetCharacterEquipmentById(characterEquipmentId);

            var currentUserId = this.User.GetId();
            var currentCharacter = this.characters.GetCharacterById(characterEquipment.CharacterId);

            if (currentCharacter.OwnerId != currentUserId)
            {
                return Unauthorized();
            }

            var equipmentForm = this.mapper.Map<EquipmentFormModel>(characterEquipment);

            equipmentForm.Equipments = this.equipments.GetEquipmentListing();

            return View(equipmentForm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(EquipmentFormModel equipmentEdit)
        {
            var characterEquipment = this.equipments.GetCharacterEquipmentById(equipmentEdit.CharacterEquipmentId);

            if (!this.equipments.EquipmentExists(equipmentEdit.EquipmentId))
            {
                this.ModelState.AddModelError(nameof(equipmentEdit.EquipmentId), "Equipment does not exist.");
            }

            if (!ModelState.IsValid)
            {
                equipmentEdit.Equipments = this.equipments.GetEquipmentListing();

                return View(equipmentEdit);
            }

            this.equipments.Edit(equipmentEdit.Count, equipmentEdit.EquipmentId, equipmentEdit.CharacterEquipmentId, equipmentEdit.Location);

            return RedirectToAction("Details", "Characters", new { characterId = characterEquipment.CharacterId });
        }

        [Authorize]
        public IActionResult Delete(int characterEquipmentId)
        {
            var characterEquipment = this.equipments.GetCharacterEquipmentById(characterEquipmentId);

            equipments.Delete(characterEquipmentId);

            return RedirectToAction("Details", "Characters", new { characterId = characterEquipment.CharacterId });
        }
    }
}
