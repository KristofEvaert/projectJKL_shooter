echo exporting
cd Game
# Build game and export it to HTML
# requires to have godot mono installed
godot --no-window --export "HTML5"
cd ..
# copies the exported game files
cp -r Game/build build/
# copies the main html file
cp projectJKL2dshooter.html build/index.html

