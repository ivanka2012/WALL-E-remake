import bpy

for i in bpy.data.materials:
    i.use_shadeless = True

for i in bpy.data.images:
    i.use_alpha = False

bpy.context.scene.game_settings.material_mode = 'GLSL'

#Lincensed under a cc-0 lincense.
#Script wirtten by me, Geljado aka Broken Symmetry lol.
#
#Press "Run Script" in the script window to activate.